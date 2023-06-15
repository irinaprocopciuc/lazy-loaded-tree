import { Component, Input } from '@angular/core';
import { TreeModel } from 'src/app/models/tree-model';
import { NodeService } from 'src/app/services/node.service';

@Component({
  selector: 'app-tree-node',
  templateUrl: './tree-node.component.html',
  styleUrls: ['./tree-node.component.scss']
})
export class TreeNodeComponent {
  @Input() node!: TreeModel;
  expanded: boolean = false;

  constructor(private treeNodeService: NodeService) { }

  toggleNode() {
    if (!this.expanded) {
      this.loadChilren(this.node);
    } else {
      this.expanded = false;
    }
  }

  loadChilren(node: TreeModel): void {
    let childrenIds: any= [];
    this.treeNodeService.getChildNodes(node.treeId).subscribe((response: TreeModel[]) => {
      childrenIds = Array.from(response[0]?.steps);
      this.node.steps = response[0]?.steps;
      this.expanded = true;
    });
  }
}
