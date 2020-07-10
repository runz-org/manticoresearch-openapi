=begin comment

Manticore Search API

This is the API for Manticore Search HTTP protocol 

The version of the OpenAPI document: 1.0.0
Contact: info@manticoresearch.com
Generated by: https://openapi-generator.tech

=end comment

=cut

#
# NOTE: This class is auto generated by OpenAPI Generator
# Please update the test cases below to test the API endpoints.
# Ref: https://openapi-generator.tech
#
use Test::More tests => 1; #TODO update number of test cases
use Test::Exception;

use lib 'lib';
use strict;
use warnings;

use_ok('WWW::OpenAPIClient::UtilsApi');

my $api = WWW::OpenAPIClient::UtilsApi->new();
isa_ok($api, 'WWW::OpenAPIClient::UtilsApi');

#
# sql test
#
{
    my $body = undef; # replace NULL with a proper value
    my $result = $api->sql(body => $body);
}


1;
