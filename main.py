import uvicorn
from fastapi import FastAPI, HTTPException
from pydantic import BaseModel

app = FastAPI()

#teste {
class Item(BaseModel):
    username: str
    excursion_name: str
    place: str

exe1_db = {
    "moura": {
        "username": "Maria",
        "excursao": "Bosque",
        "cidade": "Marília",
        "Data de partida": "24/12/2004"
    },
    "kaua": {
        "username": "Kaua",
        "excursao": "Praia",
        "cidade": "Sei lá",
        "Data de partida": "12/12/2025"
    },
    "vinicius": {
        "username": "Vini",
        "excursao": "Museu",
        "cidade": "São Paulo",
        "Data de partida": "01/02/2025"
    }
}
# }


#GET - obter todos os itens
@app.get("/excursion")
def get_all_excursions():
    users = list(exe1_db.values())
    return users

#GET - obter um caminho por usuario
@app.get("/excursion/{username}")
def get_excursions_path(username: str):
    if username.lower() not in exe1_db:
        return {"404": " User not found"}
    else:
        return exe1_db[username.lower()]

#POST - Add um novo item
@app.post("/excursion/")
def creat_excursion(item: Item):
    username = item.username.lower()
    if username in exe1_db:
        #raise é usado para exececões, oq enterrompe a execucao normal do programa.
        raise HTTPException(status_code = 400, detail = "User already exists.")
    exe1_db[username] = item.dict()
    return {"message":f"Execursion {item.excursion_name} for {username} created."}

#DELETE - remover um item
@app.delete("/excursion/{username}")
def delete_item(item : Item):
    username = item.username.lower()
    if username not in exe1_db:
        raise HTTPException(status_code = 404, detail = "User not found.")
    del exe1_db[username]
    return {"message" :f"{username} delete Successfully."}

#PUT - atualizar um item
@app.put("/excursion")
def update_item(item: Item):
    username = item.username.lower()
    if username not in exe1_db:
        raise HTTPException(status_code = 404, detail = "User not found.")
    exe1_db[username] = item.dict()
    return {"message" :f"{username} updated Successfully."}

@app.patch("/excursion")
def update_item_partial(item: Item):
    username = item.username.lower()
    if username not in exe1_db:
        raise HTTPException(status_code = 404, detail = "User not found.")
    exe1_db[username].update(item.dict(exclude_unset=True))
    return {"message" :f"{username} updated Successfully."}

if __name__ == "__main__":
    uvicorn.run(app, port=8000)