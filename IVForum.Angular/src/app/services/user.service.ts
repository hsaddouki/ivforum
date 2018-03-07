import { BaseService } from './base.service';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class UserService {

    constructor(
        private _URL:BaseService,
        private http: HttpClient
    ) { }

    postRegister(user) {
        return this.http.post(this._URL + "account/register", user)
            .map(
                res => {
                    return true;
                },
                err => {
                    console.log(err);
                    return false;
                }
            );
    }

    postLogin(email: string, password: string) {
        return this.http.post(this._URL + "account/login", { email, password })
        .map(
                res => {
                    localStorage.setItem('currentUser', JSON.stringify({ email: email, res  }));
                    return true;
                },
                err => {
                    console.log(err)
                    return false;
                }
            )
    }

    getInfoUser(userId){
        return this.http.get(this._URL + "account" + userId)
        .map(
                res => {
                    return res;
                },
                err => {
                    console.log(err)
                    return false;
                });
    }

    isSubscribed(idForum){
        return this.http.get(this._URL + "account/subscribed" + idForum)
        .map(
                res => {
                    return res;
                },
                err => {
                    console.log(err)
                    return false;
                });
    }

    subscriptions(idForum){
        return this.http.get(this._URL + "account/subscription" + idForum)
        .map(
                res => {
                    return res;
                },
                err => {
                    console.log(err)
                    return false;
                });
    }

    putUser(user){
        return this.http.put(this._URL + "account", user)
        .map(
                res => {
                    return res;
                },
                err => {
                    console.log(err)
                    return false;
                });
    }

    deleteUser(user){
        return this.http.delete(this._URL + "account", user)
        .map(
                res => {
                    return res;
                },
                err => {
                    console.log(err)
                    return false;
                });
    }

    islogged(){
        if (localStorage.getItem('currentUser') != null){
            return true;
        }
        else {
            return false;
        }
    }

    logout(): void {
        localStorage.removeItem('currentUser');    
    }
    
}

/*
- api/account/
    - GET
        - default: Obtener datos de un usuario concreto
        - {id_usuario} : Obtener datos del usuario
        - subscribed/{id_forum} : Si el usuario esta suscrito a ese forum
        - subscription/{id_forum} : Las opciones de voto que tiene el user en ese forum
    - POST
        - register : Registrar usuario
        - login : Loguear usuario
        - avatar : Cambiar imagen de perfil
    - PUT
        - default : Actualizar usuario
    - DELETE
        - default : Borrar usuario
*/