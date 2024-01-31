import numpy as np 
import pandas as pd
from sklearn import datasets
from sklearn.linear_model import LogisticRegression
from sklearn.metrics import accuracy_score
from sklearn.model_selection import train_test_split
iris=datasets.load_iris()
x=iris.data
y=(iris.target==2).astype(int)
df = pd.DataFrame(iris.data,
                  columns =iris.feature_names)
display(df)


x_train,x_test,y_train,y_test=(train_test_split(x,y,test_size=0.2,random_state=42))

model =LogisticRegression()

model.fit(x_train,y_train)

y_pred=model.predict(x_test)

accuracy=accuracy_score(y_test,y_pred)
print(f"Accuracy:{accuracy *100:.2f}%")
print(iris.target)
