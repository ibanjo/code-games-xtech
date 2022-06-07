import csv
import os

from models.research import Research


def has_feature(feat, cat, research):
    if cat == 'FEBEDevops':
        return 1 if research.FEBEDevops == feat else 0
    if cat == 'WebMobile':
        return 1 if research.WebMobile == feat else 0
    if cat == 'Technology':
        return 1 if research.Technology == feat else 0


def research_to_model_table(research: Research):
    __location__ = os.path.realpath(os.path.join(os.getcwd(), os.path.dirname(__file__)))
    with open(os.path.join(__location__, 'feature_set.csv')) as f:
        reader = csv.reader(f)
        data = [list(row) for row in reader]
        feat_map = map(lambda feat, cat: has_feature(feat, cat, research), data[0], data[1])
        return list(feat_map)
