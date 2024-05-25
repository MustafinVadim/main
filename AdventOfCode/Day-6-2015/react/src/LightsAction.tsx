import axios, {AxiosResponse} from 'axios';

type LightsAction = {
    fromX: number;
    fromY: number;
    toX: number;
    toY: number;
    action: string;
}

export async function getNext(url: string): Promise<LightsAction> {
    try {
        const response: AxiosResponse<LightsAction> = await axios.get<LightsAction>(url);
        return response.data;
    } catch (error) {
        throw new Error((error as Error).message || 'An error occurred while fetching data');
    }
}