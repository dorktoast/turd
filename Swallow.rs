enum SwallowType {
    African,
    European,
    Unknown,
}

struct Swallow {
    swallow_type: SwallowType,
}

impl Swallow {
    fn new(swallow_type: SwallowType) -> Self {
        Swallow { swallow_type }
    }

    fn airspeed_velocity(&self) -> Result<&str, &str> {
        match self.swallow_type {
            SwallowType::African => Ok("Well, we're still not sure"),
            SwallowType::European => Ok("With or without a coconut?"),
            SwallowType::Unknown => Err("I don't know that! *gets thrown off the bridge*"),
        }
    }
}

fn main() {
    let european_swallow = Swallow::new(SwallowType::European);
    let velocity = european_swallow.airspeed_velocity();
    
    match velocity {
        Ok(v) => println!("{}", v),
        Err(e) => println!("{}", e),
    }
}
