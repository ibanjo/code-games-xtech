import numpy as np  
import pandas as pd
from matplotlib import pyplot as plt
from sklearn.datasets import make_blobs
from sklearn.cluster import KMeans


class Similarity:
    def fit(self):
        data = pd.read_csv("data.csv")
        print(data)
        
        x, y = make_blobs(n_samples=300, centers=4, cluster_std=0.60, random_state=0)
        
        kmeans = KMeans(n_clusters=4)
        kmeans.fit(x)
        y_kmeans = kmeans.predict(x)
        
        return y_kmeans
    
    def result(self):
        return "Results"