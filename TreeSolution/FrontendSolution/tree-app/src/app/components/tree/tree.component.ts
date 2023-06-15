import { FlatTreeControl } from '@angular/cdk/tree';
import { Component, OnInit } from '@angular/core';
import { TreeModel } from 'src/app/models/tree-model';
import { NodeService } from 'src/app/services/node.service';

@Component({
  selector: 'app-tree',
  templateUrl: './tree.component.html',
  styleUrls: ['./tree.component.scss'],
})
export class TreeComponent implements OnInit {
  nodes: TreeModel[] = [];
  childNodes: TreeModel[] = [];
  hasChildren: boolean = false;

  constructor(private nodesService: NodeService) {}

  ngOnInit(): void {
    this.getRootNodes();
  }

  private getRootNodes(): void {
    this.nodesService
      .getRootNodes()
      .subscribe((response) => (this.nodes = response));
  }
}
