# Secure Agent
This is the code repository for the Secure Agent. More info to come.

## Building
The Secure Agent is written in [rust](https://www.rust-lang.org/en-US/). Rust uses two cli tools for its build: rustup and cargo.

### Rustup
Rustup is rust's toolchain manager. Rust ships stable, beta, and nightly versions of the compiler and standard library.
This project uses stable, but some of the tooling uses the nightly compiler. Rustup is used to update the compiler, and
switch the active toolchain. You will use rustup infrequently.

To install rustup, visit [https://www.rustup.rs](https://www.rustup.rs/) and follow the instructions.

To install or update the compiler:
```
rustup update stable
```

The tooling also requires the nightly compiler:
```
rustup update nightly
```

### Cargo
Cargo is the build tool for rust. You will use cargo frequently. It manages the build of the project, downloading dependencies,
testing, etc. You can read more about cargo and it's capabilities in the [cargo book](https://doc.rust-lang.org/cargo/).

#### Building
To build the project, use:
```
cargo build --all
```

#### Testing
To test the project, use:
```
cargo test --all
```

### Additional Tools
Rust has a few tools that help in day to day development.

#### Cargo Fmt
Cargo supports a formatting tool to automatically format the source code.

Install it with:
```
rustup component add rustfmt-preview
```

Run it with:
```
cargo fmt --all
```

By default, this will update the source files with newly formatted source files. Cargo fmt is also run as a checkin
gate to prevent code from being checked in that doesn't meet the style guidelines.

#### Cargo Clippy
Clippy is a linting tool for rust. It provides suggestions for more idiomatic rust code.

Install it with:
```
cargo +nightly install clippy
```

Run it with:
```
cargo +nightly clippy --all
```

Clippy is also run as a checkin gate.

## IDE
VS Code has good support for rust. Consider installing the following extensions:

* [Rust](https://marketplace.visualstudio.com/items?itemName=rust-lang.rust) - Syntax highlighting and intellisense support
* [Better TOML](https://marketplace.visualstudio.com/items?itemName=bungcip.better-toml) - Syntax highlighting for Cargo.toml
* [C/C++](https://marketplace.visualstudio.com/items?itemName=ms-vscode.cpptools) - Native debugger support
* [Vim](https://marketplace.visualstudio.com/items?itemName=vscodevim.vim) - For a more sophisticated editor experience :)

There is a `launch.json` configuration in this repo to setup debugging on Windows. This should work out of the box.

### Other

* [RUST Api Guidelines](https://rust-lang-nursery.github.io/api-guidelines/) - Guidelines on naming conventions, organization, etc.