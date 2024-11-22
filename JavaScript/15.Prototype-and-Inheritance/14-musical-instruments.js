function createMusicalHierarchy() {
    class Instrument {
        constructor(name, type) {
            this.name = name;
            this.type = type;
        }

        play() {
            return `${this.name} is playing a melody`;
        }

        tune() {
            console.log(`Fa-La-La: ${this.name} is tuned!`);
        }
    }

    class StringInstrument extends Instrument {
        constructor(name, type, numberOfStrings) {
            super(name, type);
            this.numberOfStrings = numberOfStrings;
        }

        play() {
            return super.play() + ` with ${this.numberOfStrings} strings`;
        }
    }

    class PercussionInstrument extends Instrument {
        constructor(name, type, drumSize) {
            super(name, type);
            this.drumSize = drumSize;
        }

        play() {
            return super.play() + ` with drum of size ${this.drumSize}`;
        }
    }

    return {Instrument, StringInstrument, PercussionInstrument};
}

createMusicalHierarchy();