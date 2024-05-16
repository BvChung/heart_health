import numpy as np

def make_prediction(xgb_clf, vector) -> bool:
    prediction = int(xgb_clf.predict(vector)[0])

    return True if prediction == 1 else False