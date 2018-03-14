import { Component, OnInit } from '@angular/core';
import { UserService } from '../../services/user.service';
import { ForumService } from '../../services/forum.service';
import { Router } from '@angular/router';
import { LoadService } from '../../services/load.service';

@Component({
    selector: 'forumsComponent',
    templateUrl: 'forums.component.html',
    styleUrls: ["forums.component.css"]
})

export class ForumsComponent implements OnInit {
    private forums;
    constructor(
        private _userService:UserService,
        private _forumService:ForumService,
        private _router:Router,
        private _loader:LoadService
    ) { }

    ngOnInit() {
        //this.newForum = new Forum();
        this.getForums();
        //this.test();
    }

    selectForum(forum){
        console.log(forum);
        this._forumService.selectForum(forum);
        this._router.navigate(["/main/forum"]);
    }

    loaded(){
        this._loader.setLoad(false);
        
    }
    

    getForums() {
        this._forumService.getForums()
        .subscribe(
            res => this.forums = res,
            err => console.log(err) 
        )
    }
    /*
    getMyForums(){
        this._forumService.getUserForums(JSON.parse(localStorage.getItem("currentUser")).id)
        .subscribe(
            res => this.forums = res,
            err => console.log(err)
        )
    }
    */
    createForum(){
        this._forumService.createForum("")
        .subscribe(
            res => {
                console.log("suscrito");
            },
            err => console.log(err)
        )
    }
    test(){
        var forum = [{'title':"potato","shortDescription":"Potato","description":"Normally, both your asses would be dead as fucking fried chicken, but you happen to pull this shit while I'm in a transitional period so I don't wanna kill you, I wanna help you. But I can't give you this case, it don't belong to me. Besides, I've already been through too much shit this morning over this case to hand it over to your dumb ass."},
        {'title':"potato","shortDescription":"Potato","description":"Normally, both your asses would be dead as fucking fried chicken, but you happen to pull this shit while I'm in a transitional period so I don't wanna kill you, I wanna help you. But I can't give you this case, it don't belong to me. Besides, I've already been through too much shit this morning over this case to hand it over to your dumb ass."},
        {'title':"potato","shortDescription":"Potato","description":"Normally, both your asses would be dead as fucking fried chicken, but you happen to pull this shit while I'm in a transitional period so I don't wanna kill you, I wanna help you. But I can't give you this case, it don't belong to me. Besides, I've already been through too much shit this morning over this case to hand it over to your dumb ass."},
        {'title':"potato","shortDescription":"Potato","description":"Normally, both your asses would be dead as fucking fried chicken, but you happen to pull this shit while I'm in a transitional period so I don't wanna kill you, I wanna help you. But I can't give you this case, it don't belong to me. Besides, I've already been through too much shit this morning over this case to hand it over to your dumb ass."}];
        this.forums = forum;
    }
}