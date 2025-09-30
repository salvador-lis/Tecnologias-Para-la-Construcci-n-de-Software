import {MedalProvider} from "../domain/MedalProvider";
import {MedalTable} from "../domain/MedalTable";

export class Paris2024Provider implements MedalProvider {
    top(n: number): MedalTable[] {
        const data: MedalTable[] = [
            {rank: 1, country: "USA", gold: 40, silver: 44, bronze: 42},
            {rank: 2, country: "CHN", gold: 40, silver: 27, bronze: 24},
            {rank: 3, country: "JPN", gold: 25, silver: 23, bronze: 26},
            {rank: 4, country: "FRA", gold: 16, silver: 26, bronze: 22},
            {rank: 5, country: "AUS", gold: 18, silver: 19, bronze: 16},
        ];
        return data.slice(0, n);
    }
}