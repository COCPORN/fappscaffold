namespace Fuse

// This doesn't work as the generated JavaScript
// is require('./Types.js'), which is a require
// format Fuse doesn't seem to support
module Types =
    type Player = { name: string; age: int }

