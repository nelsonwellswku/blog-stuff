xquery version "1.0-ml";
declare namespace ndw = "http://nelsonwells.net/blog/examples";

let $xml := <name xmlns="http://nelsonwells.net/blog/examples">
              <firstname>Nelson</firstname>
              <middlename>Dane</middlename>
              <lastname>Wells</lastname>
            </name>

return text{fn:concat(
  "First name: ", $xml/ndw:firstname/text(), "&#xa;",
  "Middle name: ", $xml/middlename/text(), "&#xa;", (: empty result! :)
  "Last name: ", xdmp:with-namespaces( ("", "http://nelsonwells.net/blog/examples"), $xml/lastname/text())
)}
