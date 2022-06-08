import numpy as np  
from sklearn.cluster import KMeans
from collections import Counter
import matplotlib.pyplot as plt
import pickle

class Similarity:

    def __init__(self):
        self.debugMode = False

    def calc_inertia(self, K, X):
        distortions = []
        for k in K:
            kmeanModel = KMeans(n_clusters=k, init='k-means++', n_init=50)
            kmeanModel.fit(X)
            distortions.append(kmeanModel.inertia_)
        return distortions

    def show_elbow(self, K, distortions):
        plt.figure(figsize=(16, 8))
        plt.plot(K, distortions, 'bx-')
        plt.xlabel('k')
        plt.ylabel('Distortion')
        plt.title('The Elbow Method showing the optimal k')
        plt.show()

    
    def fit(self, training_data):
        X = training_data.drop("idUser", 1)

        if self.debugMode:
            K = range(1, 30)
            distortions = self.calc_inertia(K, X)
            self.show_elbow(K, distortions)
        
        kmeans = KMeans(n_clusters=18, init='k-means++', n_init=50)
        kmeans.fit(X)

        y_pred_fit = kmeans.predict(X)
        data_fit = training_data.assign(cluster=y_pred_fit)

        data_fit.to_pickle("./data.pkl")
        pickle.dump(kmeans, open("./model.pkl", "wb"))

        cluster_num = Counter(kmeans.labels_)
    
    def research(self, features):
        df = pickle.load(open("./data.pkl", "rb"))
        model = pickle.load(open("./model.pkl", "rb"))

        X_input = np.array(features).reshape(1, -1)
        y_pred = model.predict(X_input)

        df_result = df[df['cluster'] == y_pred[0]]

        return df_result
