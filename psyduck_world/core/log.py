from datetime import datetime


def info(name, msg, desc=None):
    _time = datetime.now().strftime("%Y-%m-%d %H:%M:%S")
    print(f'{_time} -> [{name}] {msg} \t {desc}')
