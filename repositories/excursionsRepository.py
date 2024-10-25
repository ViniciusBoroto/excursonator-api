from sqlalchemy import create_engine
from sqlalchemy.ext.declarative. import declarative_base
from sqlalchemy import Column, String, Integer

engine = create_engine()

Base = declarative_base()

class Excursion(Base):
    pass

class ExcursionRepository():
    def __init__(self) -> None:
        pass

    def create(self, excursion:Excursion) -> bool:
        pass

    def get_by_id(self, id:int) -> Excursion:
        pass

    def get_all(self) -> Excursion:
        pass
    
    def update(self, excursion:Excursion) -> Excursion:
        pass

    def delete(self, id:int) -> bool:
        pass
        
