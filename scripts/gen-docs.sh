# Execute this script from solution directory
# This script will install docfx dependencies and build the documentation
# Set .Net project location to `wtns.lib`

# Install dependencies
echo --- Attempting to install docfx dependencies
sudo apt-get install \
  libnss3\
  libnspr4\
  libatk1.0-0\
  libatk-bridge2.0-0\
  libcups2\
  libatspi2.0-0\
  libxcomposite1\
  libxdamage1\
  libxfixes3\
  libxrandr2\
  libgbm1\
  libxkbcommon0\
  libpango-1.0-0\
  libcairo2\
  libasound2
echo ""

# Install docfx tool
echo --- Attempting to install docfx tooling
dotnet tool install -g docfx
echo ""

# Initialize docfx
echo --- Attempting to initialize docfx project
docfx init -o ./docfx/
echo ""

# Build docfx project
echo --- Attempting to build docfx project
docfx build ./docfx/docfx.json -o ./docfx/
echo ""
