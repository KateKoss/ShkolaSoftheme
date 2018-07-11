import { Component, OnInit, OnDestroy } from "@angular/core";

import { Article } from "./article-details/article.model"
import { ArticleListService } from "./article-list.service";
import { Subscription } from "rxjs";

@Component({
    selector: 'articles-list',
    templateUrl: './article-list.component.html',
    styleUrls: ['./article-list.component.css']
})
export class ArticlesListComponent implements OnInit{
    articles: Article[];

    constructor(private service: ArticleListService){ }

    ngOnInit(){
        this.service.getArticles().subscribe(
            response => this.articles = response,
            error => console.log(error)
        )
    }

    // ngOnDestroy() {
    //     this.subscription.unsubscribe();
    // }
}