import sys
from flask import Flask, render_template, request

from models.research import Research
from similarity import Similarity
from utils.map_input import map_input
from utils.model_mapping import research_to_model_table

app = Flask(__name__)


@app.route("/")
def init():
    return "<p>CodeGames 2022</p>"


@app.route("/fitSearch")
def fit_search():
    sim = Similarity()
    x = sim.fit()
    print(x, file=sys.stderr)

    return render_template("fitSearch.html", values=x)


@app.route("/getSimilarities", methods=['POST'])
@map_input(Research)
def get_similarities(research):
    features = research_to_model_table(research)
    return "<p>Similarities</p>"


if __name__ == '__main__':
    app.run(debug=True)
