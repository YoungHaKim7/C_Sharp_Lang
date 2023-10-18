use std::collections::HashMap;

fn main() {
    let someArray: [i32; 2] = [1, 2];
    dbg!(someArray);

    let mut something_vec = vec!["a".to_owned(), "b".to_owned()];
    something_vec.push("c".to_owned());
    dbg!(something_vec);

    let something_tuple = (1, 2);
    println!(
        "tuple 0 = {}, tuple1 = {}",
        something_tuple.0, something_tuple.1
    );

    let mut something_hashmap = HashMap::from([
        ("Foo".to_owned(), "Bar".to_owned()),
        ("Baz".to_owned(), "Qux".to_owned()),
    ]);
    something_hashmap.insert("hi".to_owned(), "there".to_owned());
    dbg!(something_hashmap);
}
