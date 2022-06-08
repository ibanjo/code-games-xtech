import numpy as np  
import pandas as pd
from sklearn.cluster import KMeans
from collections import Counter
import pickle

class Similarity:
    
    def fit(self):
        data = pd.read_csv("data.csv")
        X = data.drop("idUser", 1)
        
        kmeans = KMeans(n_clusters=5, init='k-means++', max_iter=200, n_init=100)
        kmeans.fit(X)

        y_pred_fit = kmeans.predict(X)
        X_dist = kmeans.transform(X) ** 2

        df = data.assign(cluster=y_pred_fit, distance=X_dist.sum(axis=1))

        df.to_pickle("./data.pkl")
        pickle.dump(kmeans, open("./model.pkl", "wb"))

        cluster_num = Counter(kmeans.labels_)
        return cluster_num
    
    def research(self, features):
        df = pickle.load(open("./data.pkl", "rb"))
        model = pickle.load(open("./model.pkl", "rb"))

        X_input = np.array(features).reshape(1, -1)
        y_pred = model.predict(X_input)

        df_result = df[df['cluster'] == y_pred[0]]

        return y_pred, df_result
