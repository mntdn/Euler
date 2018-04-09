function IsPrime(n){
    if(n === 1 || n === 3)
        return true;
    if(n % 2 === 0)
        return false;
    var isPrime = true;
    for(var i = 2; i < n/2; i++){
        if(n%i === 0){
            isPrime = false;
            break;
        }
    }
    return isPrime;
}

function Factors(n){
    var factors = [];
    for(var i=1; i < n/2; i+=2){
        if(i%2 !== 0 && n%i === 0){
            factors.push(i);
        }
    }
    return factors;
}

function BiggestPrime(n){
    var startNumber = n;
    if(startNumber%2 !== 0)
        startNumber--;
    startNumber /= 2;
    for(; startNumber > 1; startNumber--){
        if(IsPrime(startNumber) && n%startNumber === 0){
            console.log(startNumber);
            break;
        }
    }
}

var numberToTest = 600851475;//143;

var primeList = [];
var start = new Date()
for(var i = 1; i < numberToTest / 2; i+=2){
    if(IsPrime(i)){
        primeList.push(i);
    }
}
console.log(primeList.length);
// console.log(IsPrime(2))
// BiggestPrime(13195);
// console.log(Factors(6008514751).length)
var end = new Date() - start;
console.info("Execution time: %dms", end);