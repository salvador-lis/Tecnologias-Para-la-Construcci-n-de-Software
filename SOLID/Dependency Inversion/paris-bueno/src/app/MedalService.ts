import {MedalProvider} from "../domain/MedalProvider";

export class MedalService {
    constructor(private provider: MedalProvider) {}

    showTop(n: number, title = "Paris 2024"){
        console.log(`\n=== ${title} ===`);
        console.table(this.provider.top(n));
    }
}