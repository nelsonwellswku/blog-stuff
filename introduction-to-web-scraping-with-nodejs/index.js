var http = require('http');

var options;
var regex = /<a.*tip.*>(.*)<\/a>/g;

for(var i = 1; i <= 26; i++) {

  options = {
    host: 'clichesite.com',
    path: '/alpha_list.asp?which=lett+' + i
  };

  http.get(options, function(res) {

    // accessible to 'data' and 'end' events
    var data = '';

    res.on('data', function(chunk) {
      data += chunk.toString();
    })
    .on('end', function() {
      while((match = regex.exec(data))) {
        console.log(match[1]);
      }
    });
  });

}
