use std::panic;

pub fn add(left: u64, right: u64) -> u64 {
    left + right
}

#[unsafe(no_mangle)]
pub extern "C" fn i_panic() {
    panic!("This is a panic from the Rust library!");
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn it_works() {
        let result = add(2, 2);
        assert_eq!(result, 4);
    }
}
