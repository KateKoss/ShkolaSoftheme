import { Component, Input } from '@angular/core';

import { Article } from './article.model'
import { tick } from '@angular/core/testing';

@Component({
    selector: 'article-details',
    templateUrl: './article-details.component.html',
    styleUrls: ['./article-details.component.css']
})
export class ArticleDetailsComponent{    
    @Input()
    article : Article;

    isColorGrey : boolean = false;
    changeColor​(){
        this.isColorGrey = !this.isColorGrey;
    }
}

