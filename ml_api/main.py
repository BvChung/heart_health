from fastapi import FastAPI
from pydantic import BaseModel
from xgboost import XGBClassifier
import numpy as np
from model import make_prediction

"""
uvicorn main:app --reload
http://127.0.0.1:8000/docs
"""

app = FastAPI()
xgb_clf = XGBClassifier()
xgb_clf.load_model("xgb_ml_model.json")


class PatientMedicalRecords(BaseModel):
    age: int
    anemia: int
    creatine_phosphokinase: int
    ejection_fraction: int
    platelets: int
    serum_creatinine: float
    serum_sodium: int
    days_until_follow_up: int


@app.get("/health")
def health():
    return {"message": "OK"}


@app.post("/model")
def model_prediction(record: PatientMedicalRecords):
    """
    Given input vector of patient medical records return true or false if patient is deceased
    Ex.
    {
        "age": 75,
        "anemia": 0,
        "creatine_phosphokinase": 582,
        "ejection_fraction": 20,
        "platelets": 26500,
        "serum_creatinine": 1.9,
        "serum_sodium": 130,
        "days_until_follow_up": 4
    }
    """
    record_dict = record.model_dump()
    data = [val for val in record_dict.values()]
    vector = np.array(data).reshape(1, -1)
    patient_deceased = make_prediction(xgb_clf, vector)

    return {"patient_deceased": patient_deceased}
