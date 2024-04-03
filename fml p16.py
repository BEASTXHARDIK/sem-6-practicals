import numpy as np 
import matplotlib.pyplot as plt 

np.random.seed(0)
normal_data = np.random.normal(loc=0, scale=1 ,size = 100)

anomaly_index = 75
normal_data[anomaly_index] = 10

mean = np.mean(normal_data)
std_dev = np.std(normal_data)
z_scores = (normal_data - mean) / std_dev

threshold = 3
anomalies = np.where(np.abs(z_scores) > threshold)[0]

plt.figure(figsize=(10,6))

plt.plot(normal_data[np.setdiff1d(range(len(normal_data)),anomalies)],marker='o',linestyle='',color='blue',label='Normal Data Points')

plt.plot(normal_data[anomalies],marker='o',linestyle='',color='red',label='Anomaalies')

plt.title('Anomaly Detection  Using Z-score')
plt.xlabel('Index')
plt.ylabel('Value')
plt.legend()
plt.grid(True)
plt.show()
