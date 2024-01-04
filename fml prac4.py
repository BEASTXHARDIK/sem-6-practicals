import pandas as po
import os
from sklearn.model_selection import train_test_split

file_path=os.path.abspath('Real-estate.csv')
df=po.read_csv(file_path)

df.reset_index(drop=True,inplace=True)

print("sample of loaded dataset")
print(df.head())

x=df.iloc[:,1:-1]
y=df.iloc[:,-1]

x_train,x_test,y_train,y_test=train_test_split(x,y,test_size=0.2,random_state=42)

print("\nShapes of the resulting sets:" )

print(f"x_train shape:{x_train.shape}")
print(f"x_test shape:{x_test.shape}")
print(f"y_train shape:{y_train.shape}")
print(f"y_test shape:{y_test.shape}")

print(" values of y train")
print(y_train)
