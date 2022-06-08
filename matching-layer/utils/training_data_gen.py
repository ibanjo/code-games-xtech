import numpy
import pandas as pd

from models.research import Research
from utils.model_mapping import research_to_model_table

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
        table_entry.insert(0, user_id)
        table_entries.append(table_entry)

    df = pd.DataFrame(table_entries, columns=columns)
    return df
