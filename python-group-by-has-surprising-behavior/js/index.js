const friends = [
  { coupleId: 3, name: "John" },
  { coupleId: 1, name: "Thomas" },
  { coupleId: 2, name: "Eugene" },
  { coupleId: 2, name: "Beatrice" },
  { coupleId: 1, name: "Imani" },
  { coupleId: 3, name: "Mary" },
];

const friendsGroups = Map.groupBy(friends, (x) => x.coupleId);
// console.log(friendsGroups);
for (const [key, grouping] of friendsGroups) {
  // console.log("ob is ", ob)
  console.log(key, "-->", grouping.map((obj) => obj.name).join(" loves "));
}
