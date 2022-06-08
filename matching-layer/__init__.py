import sys
from flask import Flask, render_template, request

from models.research import Research
from similarity import Similarity
from utils.map_input import map_input
from utils.model_mapping import research_to_model_table
from utils.training_data_gen import generate_training_data

app = Flask(__name__)


@app.route("/")
def init():
    return "<p>CodeGames 2022</p>"


@app.route("/fitSearch", methods=['POST'])
def fit_search():
    training_data = generate_training_data()
    sim = Similarity()
    x = sim.fit()
    #return render_template("fitSearch.html", values=x)
    return x


@app.route("/getSimilarities", methods=['POST'])
@map_input(Research)
def get_similarities(research):
    features = research_to_model_table(research)
    sim = Similarity()
    y_pred, df_result = sim.research(features)
    #return render_template("similarities.html", cluster=y_pred[0], values=df_result)
    return df_result


if __name__ == '__main__':
    app.run(debug=True)
