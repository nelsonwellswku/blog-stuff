from itertools import groupby

def main():
    friends = [
        {"couple_id": 3, "name": "John"},
        {"couple_id": 1, "name": "Thomas"},
        {"couple_id": 2, "name": "Eugene"},
        {"couple_id": 2, "name": "Beatrice"},
        {"couple_id": 1, "name": "Imani"},
        {"couple_id": 3, "name": "Mary"}
    ]

    friends_groups = groupby(friends, lambda x: x["couple_id"])

    for (key, grouping) in friends_groups:
        print(key, "-->", " loves ".join([obj["name"] for obj in grouping]))

    #---------

    sorted_friends = sorted(friends, key=lambda x: x["couple_id"])
    sorted_friends_groups = groupby(sorted_friends, lambda x: x["couple_id"])

    for (key, grouping) in sorted_friends_groups:
        print(key, "-->", " loves ".join([obj["name"] for obj in grouping]))

if __name__ == "__main__":
    main()
