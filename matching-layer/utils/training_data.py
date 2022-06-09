from models.research import Research
import numpy
import pandas as pd

from utils.model_mapping import research_to_model_table

columns = ['idUser', 'Frontend', 'Backend', 'DevOps', 'Web', 'Mobile', 'Angular', 'Vue', 'React', 'Svelte', '.NET', 'Spring', 'Laravel', 'Django', 'ExpressJS']

def generate_training_data_from_json(values):
    table_entries = []
    for data in values:

        userId = data['personId']
        skills = data['skills']

        for skill in skills:
            user_model = Research(userId, 0, 0, skill['FEBEDevops'], skill['WebMobile'], skill['Technology'],
                                  numpy.random.randint(0, 3))

            table_entry = research_to_model_table(user_model)
            table_entry.insert(0, userId)
            table_entries.append(table_entry)

    df = pd.DataFrame(table_entries, columns=columns)
    return df

