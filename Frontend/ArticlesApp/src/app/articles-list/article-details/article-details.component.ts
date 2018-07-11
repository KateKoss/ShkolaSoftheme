import { Component, Input, OnInit, OnDestroy } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { switchMap } from 'rxjs/operators';
import { Subscription } from 'rxjs';

import { Article } from './article.model'
import { ArticleListService } from '../article-list.service';

@Component({
    selector: 'article-details',
    templateUrl: './article-details.component.html',
    styleUrls: ['./article-details.component.css']
})
export class ArticleDetailsComponent implements OnInit, OnDestroy{    
    article : Article;
    id: string;
    isColorGrey : boolean = false;
    private subscription: Subscription;
    
    constructor(private route: ActivatedRoute, private articleService: ArticleListService) { }

    ngOnInit() {
        this.subscription = this.route.params.pipe(
            switchMap(params => {
                this.id = params['id'];
                return this.articleService.getArticle(this.id);
            }))
            .subscribe(response => this.article = response);
    }
    
    ngOnDestroy() {
        this.subscription.unsubscribe();
    }

    changeColor​(){
        this.isColorGrey = !this.isColorGrey;
    }
}

