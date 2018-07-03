import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { HttpClient } from '@angular/common/http';

import { Article } from "./article-details/article.model";

const requestUrl = 'http://localhost:3000';

@Injectable()
export class ArticleListService{
    constructor(private http: HttpClient){}

    getArticles() : Observable<Article[]> {
        return this.http.get<Article[]>(`${requestUrl}/articles`);
    }

    getArticle(id : string){
        return this.http.get<Article>(`${requestUrl}/articles/${id}`);
    }
}