import uvicorn
from fastapi import FastAPI, HTTPException
from pydantic import BaseModel

app = FastAPI()

#GET - obter todos os itens
@app.get("/excursion")
def get_all_excursions():
    pass

#GET - obter um caminho por usuario
@app.get("/excursion/{id}")
def get_excursions_path():
    pass

#POST - Add um novo item
@app.post("/excursion/")
def creat_excursion():
   pass

#DELETE - remover um item
@app.delete("/excursion/{id`}")
def delete_item():
    pass

#PUT - atualizar um item
@app.put("/excursion")
def update_item():
    pass


if __name__ == "__main__":
    uvicorn.run(app, port=8000)