declare option xdmp:mapping "false";

declare function local:reformat-person(
  $firstname as xs:string,
  $lastname as xs:string,
  $alias as xs:string)
{
  <person>
    <firstname>{$firstname}</firstname>
    <lastname>{$lastname}</lastname>
    <alias>{$alias}</alias>
  </person>
};

let $firstname := "nelson"
let $lastname := "wells"
let $alias := "street fighter master"
let $aliases := ("tekken master", "mortal kombat master")
let $missing-aliases := ()
return <persons>{(
  local:reformat-person($firstname, $lastname, $alias),
  local:reformat-person($firstname, $lastname, $aliases),
  (: this one doesn't actually execute! :)
  local:reformat-person($firstname, $lastname, $missing-aliases)
)}</persons>