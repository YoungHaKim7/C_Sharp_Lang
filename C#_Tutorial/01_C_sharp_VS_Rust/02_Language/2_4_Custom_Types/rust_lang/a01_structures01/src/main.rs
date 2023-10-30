use std::fmt::{self, Display, Formatter};

#[derive(Debug)]
struct Rectangle {
    x1: i32,
    y1: i32,
    x2: i32,
    y2: i32,
}

impl Rectangle {
    pub fn new(x1: i32, y1: i32, x2: i32, y2: i32) -> Self {
        Self { x1, y1, x2, y2 }
    }

    pub fn x1(&self) -> i32 {
        self.x1
    }
    pub fn y1(&self) -> i32 {
        self.y1
    }
    pub fn x2(&self) -> i32 {
        self.x2
    }
    pub fn y2(&self) -> i32 {
        self.y2
    }

    pub fn length(&self) -> i32 {
        self.y2 - self.y1
    }

    pub fn width(&self) -> i32 {
        self.x2 - self.x1
    }

    pub fn top_left(&self) -> (i32, i32) {
        (self.x1, self.y1)
    }

    pub fn bottom_right(&self) -> (i32, i32) {
        (self.x2, self.y2)
    }

    pub fn area(&self) -> i32 {
        self.length() * self.width()
    }

    pub fn is_square(&self) -> bool {
        self.width() == self.length()
    }
}

impl Display for Rectangle {
    fn fmt(&self, f: &mut Formatter<'_>) -> fmt::Result {
        write!(f, "(({},{}), ({},{}))", self.x1, self.y1, self.x2, self.y2)
    }
}

fn main() {
    let rect = Rectangle::new(12, 34, 56, 78);
    let rect_is_square = Rectangle::is_square(&rect);
    let rect_lenth = Rectangle::length(&rect);
    let rect_width = Rectangle::width(&rect);
    println!("Rectangle = {rect}");
    println!("Rectangle = {rect_is_square}");
    println!("Rectangle = {rect_lenth}");
    println!("Rectangle = {rect_width}");
}
