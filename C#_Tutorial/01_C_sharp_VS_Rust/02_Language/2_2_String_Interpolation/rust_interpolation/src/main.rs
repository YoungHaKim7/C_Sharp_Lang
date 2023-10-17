use std::fmt::{self, Display, Formatter};

struct Person {
    name: String,
    age: i32,
}

impl Display for Person {
    fn fmt(&self, f: &mut Formatter<'_>) -> fmt::Result {
        write!(f, "Person {{ name: {}, age: {}}}", self.name, self.age)
    }
}
fn main() {
    let person = Person {
        name: "John".to_owned(),
        age: 42,
    };

    println!("{person}");
}
