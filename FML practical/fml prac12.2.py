import numpy as np
import matplotlib.pyplot as plt

num_points =100
num_clusters =2

points_per_cluster=num_points//num_clusters
points=[]
for i in range(num_clusters):
  center=np.random.rand(2)*10
  cluster_points= center + np.random.randn(points_per_cluster,2)
  points.extend(cluster_points)

points=np.array(points)

plt.scatter(points[:,0],points[:,1],c='b',marker='o')
plt.title('Random Generated Clusters')
plt.xlabel('X')
plt.ylabel('Y')
plt.grid(True)
plt.show()
