var result = 0;

function Fibo(a, b, limit){
    // console|.log(a+b);
    if((a+b) % 2 === 0)
        result += a+b;
    if(b + a+b < limit)
        Fibo(b, a+b, limit);
}

Fibo(0,1,4000000);
console.log(result)