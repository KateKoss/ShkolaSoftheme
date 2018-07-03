import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { switchMap } from 'rxjs/operators';
import { Subscription } from 'rxjs';

import { Article } from './article.model'
import { tick } from '@angular/core/testing';
import { ArticleListService } from '../article-list.service';

@Component({
    selector: 'article-details',
    templateUrl: './article-details.component.html',
    styleUrls: ['./article-details.component.css']
})
export class ArticleDetailsComponent implements OnInit{    
    @Input()
    article : Article;
    private subscription: Subscription;
    
    constructor(private route: ActivatedRoute, private articleService: ArticleListService){

    }

    ngOnInit() {
        this.subscription = this.route.params.pipe(
            switchMap(params => {
                this.article.id = params['id'];
                return this.articleService.getArticle(this.article.id);
            }))
            .subscribe(res => this.article = res);
    }

    isColorGrey : boolean = false;
    changeColor​(){
        this.isColorGrey = !this.isColorGrey;
    }
}

