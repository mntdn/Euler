function SumOfMultiples(limit){
    var sum = 0;
    for(;limit > 0; limit--){
        if(limit%3 === 0 || limit%5 === 0){
            sum += limit;
        }
    }
    return sum;
}

console.log(SumOfMultiples(999));