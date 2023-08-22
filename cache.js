class Developer {
    constructor() {
        this.patience = 100;
        this.debuggingSkills = "Intermediate";
    }

    browseWebsite() {
        if (Math.random() > 0.5) {
            console.log("Oops, the website didn't load properly.");
            this.clearCache();
        } else {
            console.log("The website loaded successfully!");
        }
    }

    clearCache() {
        if (this.patience > 0) {
            console.log("Clearing browser cache...");
            this.patience -= 10;
            
            if (this.patience === 0) {
                console.log("I'm going for a walk.");
            } else {
                this.browseWebsite();
            }
        } else {
            console.log("Is it the weekend yet?");
        }
    }
}

const dev = new Developer();
dev.browseWebsite();

// dorktoast