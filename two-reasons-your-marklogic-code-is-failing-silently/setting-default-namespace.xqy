xquery version "1.0-ml";
declare default element namespace "http://nelsonwells.net/blog/examples";

let $xml := <name xmlns="http://nelsonwells.net/blog/examples">
              <firstname>Nelson</firstname>
              <middlename>Dane</middlename>
              <lastname>Wells</lastname>
            </name>

return text{fn:concat(
  "First name: ", $xml/firstname/text(), "&#xa;",
  "Middle name: ", $xml/middlename/text(), "&#xa;", 
  "Last name: ",  $xml/lastname/text()
)}
