var computed = {};

var fib = function(n) {
  if(n == 0 || n == 1) {
    return n;
  }

  if(computed[n]) {
    return computed[n];
  }

  var val = fib(n - 1) + fib(n - 2);
  computed[n] = val;
  return val;
}

console.log(fib(10));
