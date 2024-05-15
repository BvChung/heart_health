# Heart Failure Patient Classifcation Machine Learning Model

## Project Overview

Exploratory Data Analysis (EDA) and Machine Learning (ML) models were utilized to predict the death of heart failure patients given this medical record dataset. The dataset was initially preprocessed eliminating missing values and outliers. The ML models used were Logistic Regression, K Nearest Neighbors, Random Forest, and XGBoost. The preprocessed dataset was split into training/validation and test subsets at a ratio of 70:30. Hyperparameter tuning with cross validation was performed and performance metrics were evaluated on the test subset containing unseen data. The best model for this classification problem balancing model complexity in terms of bias and variance was XGBoost.

## Code Structure

```bash
.
├── heart_failure_eda.ipynb
├── heart_failure_ml_models.ipynb
├── ml_api
│   ├── main.py
│   ├── requirements.txt
│   └── xgb_ml_model.json
└── preprocessed_heart_failure_dataset.csv
```
