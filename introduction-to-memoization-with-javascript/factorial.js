var factorial = (function() {
  var lookup = {};

  return {
    //show_lookup is mainly for debugging purposes
    show_lookup : function() { return lookup; },

    run : {

      naive : function(n) {
        if(n <= 1) { return 1; }
        return n * factorial.run.naive(n - 1);
      },
    
      memoized : function(n) {
        if(n <= 1) { return 1; }

        if(lookup[n]) {
          return lookup[n];
        }
     
        lookup[n] = n * factorial.run.memoized(n - 1);
        return lookup[n];
      }

    }
  };
})();

var caller = function(method) {
  var start = (new Date()).getTime();

  for(var i = 0; i <= 150; i++) {
    method(i);
  }

  for(var j = 150; j > 1; j--) {
    method(j);
  }

  return (new Date()).getTime() - start;
};

console.log(caller(factorial.run.naive));
console.log(caller(factorial.run.memoized));
