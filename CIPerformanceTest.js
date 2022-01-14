import http from 'k6/http';
import { sleep } from 'k6';

export const options = {
    duration: '1m',
    vus: 50,
    thresholds: {
        http_req_duration: ['p(99)<400'],
        http_req_duration: ['p(95)<300'],
        http_req_failed:['rate<0.01']
    },
};

export default function () {
    const res = http.get('http://test.k6.io/');
    sleep(1);
}
