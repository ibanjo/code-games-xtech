import sys
from flask import Flask, render_template
from similarity import Similarity

app = Flask(__name__)

@app.route("/")
def init():
    return "<p>CodeGames 2022</p>"

@app.route("/fitSearch")
def fitSearch():
    sim = Similarity()
    X = sim.fit()
    return render_template("fitSearch.html", values = X)

@app.route("/getSimilarities")
def getSimilarities():
    sim = Similarity()
    y = sim.result()
    return render_template("similarities.html", values = y)
    
if __name__ == '__init__':
    app.run(debug=True)