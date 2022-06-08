import numpy
import pandas as pd

from models.research import Research
from utils.model_mapping import research_to_model_table

personId = ('C567C61B-4D95-4F3B-B4B6-0AABF6DFF459', '6297CF87-08B5-49B6-9CA6-0DC0AF6A3D21', '2139354F-D92E-4799-BA64-0F11D310E4E1', '9C1D3DFA-DE29-4EA8-BB6B-1443D4A3160B', 'C1A7EB76-651B-4C10-96A8-27328C722EEC', 'F888E8C4-9401-44E0-9EC6-65867B249889', 'EBFCE3C9-342C-4C36-B585-7028647653E1', '2775D42E-C6F6-417B-8860-7E21419C5718', '98851F86-9DC5-4A96-9258-8A80C35ABBCD', '92A8316E-08D8-4939-B974-90E6E36E6DB8', '3DBDFF94-E5B0-4503-9622-99A55359210F', '7B81A1D6-D343-47A8-AD87-D2BF94E73327', 'B689D378-F7F1-4F9A-890B-EE967B6A014A', '47897412-F70E-4F01-9A67-FD8474838CA8')

columns = ['idUser', 'Frontend', 'Backend', 'DevOps', 'Web', 'Mobile', 'Angular', 'Vue', 'React', 'Svelte', '.NET', 'Spring', 'Laravel', 'Django', 'ExpressJS']
skill_areas = ('Frontend', 'Backend', 'DevOps',)
skill_envs = ('Web', 'Mobile',)
skill_tree = {
    'Frontend': ('Angular', 'Vue', 'React', 'Svelte',),
    'Backend': ('.NET', 'Spring', 'Laravel',),
    'DevOps': ('Django', 'ExpressJS',)
}


def generate_training_data():
    user_ids = numpy.arange(1000)
    table_entries = []
    for user_id in user_ids:
        skill_area = numpy.random.choice(skill_areas)
        available_skills = skill_tree[skill_area]
        skill = numpy.random.choice(available_skills)
        skill_env = numpy.random.choice(skill_envs)
        user_model = Research(user_id, 0, 0, skill_area, skill_env, skill, numpy.random.randint(0, 3))
        table_entry = research_to_model_table(user_model)
        table_entry.insert(0, numpy.random.choice(personId))
        table_entries.append(table_entry)

    df = pd.DataFrame(table_entries, columns=columns)
    return df
