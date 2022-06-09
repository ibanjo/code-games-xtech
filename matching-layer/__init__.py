from flask import Flask, request
import pandas as pd

from models.research import Research
from similarity import Similarity
from utils.map_input import map_input
from utils.model_mapping import research_to_model_table
from utils.training_data import generate_training_data_from_json

app = Flask(__name__)

@app.route("/")
def init():
    return "<p>CodeGames 2022</p>"

@app.route("/fitSearch", methods=['POST'])
def fit_search():
    values = request.get_json()
    data = generate_training_data_from_json(values)
    training_data = pd.DataFrame(data)
    training_data.head()
    sim = Similarity()
    sim.fit(training_data)
    return "True"

@app.route("/getSimilarities", methods=['POST'])
@map_input(Research)
def get_similarities(research):
    features = research_to_model_table(research)
    sim = Similarity()
    df_result = sim.research(features)
    id_user = df_result["idUser"]
    return id_user.T.to_dict()

if __name__ == '__main__':
    app.run(debug=True)
