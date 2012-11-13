var invert = function (obj) {
 
  var new_obj = {};

  for (var prop in obj) {
    if(obj.hasOwnProperty(prop)) {
      new_obj[obj[prop]] = prop;
    }
  }

  return new_obj;
};

var obj = {
  firstname : "nelson",
  middlename : "dane",
  lastname: "wells",
  0 : "number"
};

var name = '';

for(var value in invert(obj)) {
  name += value + ' '; 
}

console.log(name.trim());

if(invert(obj)['dane']) {
  //value exists in the hash
  console.log("Value exists");
} else {
  console.log("Value does not exist");
}

if(invert(obj)['number']) {
  console.log("Value exists");
} else {
  console.log("Value does not exist");
};

console.log(typeof(invert(obj)['number']));
