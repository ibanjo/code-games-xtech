from flask import request


def map_input(the_class):
    def wrap(f):
        def decorator(*args):
            obj = the_class(**request.get_json())
            return f(obj)
        return decorator
    return wrap
