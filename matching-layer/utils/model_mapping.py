import csv
import os

from models.research import Research


def has_feature(feat, cat, research):
    if cat == 'FEBEDevops':
        return research.FEBEDevops == feat
    if cat == 'WebMobile':
        return research.WebMobile == feat
    if cat == 'Technology':
        return research.Technology == feat


def research_to_model_table(research: Research):
    __location__ = os.path.realpath(os.path.join(os.getcwd(), os.path.dirname(__file__)))
    with open(os.path.join(__location__, 'feature_set.csv')) as f:
        reader = csv.reader(f)
        data = [list(row) for row in reader]
        feat_map = map(lambda feat, cat: has_feature(feat, cat, research), data[0], data[1])
        return list(feat_map)
