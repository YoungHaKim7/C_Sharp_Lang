use std::io::{self, Write};

fn main() {
    println!("Hello, World!");

    fn check_group(s: &str) -> bool {
        match s {
            "admin" | "supervisor" | "IT" | "HR" => true,
            _ => false,
        }
    }

    // 테스트
    let s = "IT";
    let ok = check_group(s);
    println!("{}", ok);
}
