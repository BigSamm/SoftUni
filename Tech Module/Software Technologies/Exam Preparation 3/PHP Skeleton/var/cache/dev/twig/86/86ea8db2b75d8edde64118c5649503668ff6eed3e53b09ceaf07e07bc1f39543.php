<?php

/* :film:edit.html.twig */
class __TwigTemplate_9d3ada544996d38b99b52b7d94f9ee3aca463a3c8a3314d0c2107d80bf82585c extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", ":film:edit.html.twig", 1);
        $this->blocks = array(
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_286913dcca4abdfd763ee037faa6258f38d2f20da2430cf3c34208733c0b1fe5 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_286913dcca4abdfd763ee037faa6258f38d2f20da2430cf3c34208733c0b1fe5->enter($__internal_286913dcca4abdfd763ee037faa6258f38d2f20da2430cf3c34208733c0b1fe5_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":film:edit.html.twig"));

        $__internal_f2ea918d03c54381459cbf5441704e2bb68f345c8077dbf744fd8ba780595266 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_f2ea918d03c54381459cbf5441704e2bb68f345c8077dbf744fd8ba780595266->enter($__internal_f2ea918d03c54381459cbf5441704e2bb68f345c8077dbf744fd8ba780595266_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":film:edit.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_286913dcca4abdfd763ee037faa6258f38d2f20da2430cf3c34208733c0b1fe5->leave($__internal_286913dcca4abdfd763ee037faa6258f38d2f20da2430cf3c34208733c0b1fe5_prof);

        
        $__internal_f2ea918d03c54381459cbf5441704e2bb68f345c8077dbf744fd8ba780595266->leave($__internal_f2ea918d03c54381459cbf5441704e2bb68f345c8077dbf744fd8ba780595266_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_2edc4407e8bc670790b91da0a5db18e1678d7117f999dc92fc1cfa6ea3e474ef = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_2edc4407e8bc670790b91da0a5db18e1678d7117f999dc92fc1cfa6ea3e474ef->enter($__internal_2edc4407e8bc670790b91da0a5db18e1678d7117f999dc92fc1cfa6ea3e474ef_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_a42af9fa46a1de898cf26e912a5b0e404b530671575e016e3e70c752527c2bec = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_a42af9fa46a1de898cf26e912a5b0e404b530671575e016e3e70c752527c2bec->enter($__internal_a42af9fa46a1de898cf26e912a5b0e404b530671575e016e3e70c752527c2bec_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "    <h1>Edit Film</h1>
    <section>
        <form method=\"POST\">
            <div>
                <label for=\"name\">Name</label>
                <input type=\"text\" id=\"name\" value=\"";
        // line 9
        echo twig_escape_filter($this->env, $this->getAttribute(($context["film"] ?? $this->getContext($context, "film")), "name", array()), "html", null, true);
        echo "\" name=\"film[name]\" />
                <label for=\"genre\">Genre</label>
                <input type=\"text\" id=\"genre\" value=\"";
        // line 11
        echo twig_escape_filter($this->env, $this->getAttribute(($context["film"] ?? $this->getContext($context, "film")), "genre", array()), "html", null, true);
        echo "\" name=\"film[genre]\" />
                <label for=\"director\">Director</label>
                <input type=\"text\" id=\"director\" value=\"";
        // line 13
        echo twig_escape_filter($this->env, $this->getAttribute(($context["film"] ?? $this->getContext($context, "film")), "director", array()), "html", null, true);
        echo "\" name=\"film[director]\" />
                <label for=\"year\">Year</label>
                <input type=\"text\" id=\"year\" value=\"";
        // line 15
        echo twig_escape_filter($this->env, $this->getAttribute(($context["film"] ?? $this->getContext($context, "film")), "year", array()), "html", null, true);
        echo "\" name=\"film[year]\" />

                ";
        // line 17
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Form\TwigRenderer')->searchAndRenderBlock($this->getAttribute(($context["form"] ?? $this->getContext($context, "form")), "_token", array()), 'row');
        echo "

                <button type=\"submit\" class=\"accept\">Edit</button>
                <button type=\"button\" onclick=\"location.href='/'\" class=\"cancel\">Cancel</button>
            </div>
        </form>
    </section>
";
        
        $__internal_a42af9fa46a1de898cf26e912a5b0e404b530671575e016e3e70c752527c2bec->leave($__internal_a42af9fa46a1de898cf26e912a5b0e404b530671575e016e3e70c752527c2bec_prof);

        
        $__internal_2edc4407e8bc670790b91da0a5db18e1678d7117f999dc92fc1cfa6ea3e474ef->leave($__internal_2edc4407e8bc670790b91da0a5db18e1678d7117f999dc92fc1cfa6ea3e474ef_prof);

    }

    public function getTemplateName()
    {
        return ":film:edit.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  76 => 17,  71 => 15,  66 => 13,  61 => 11,  56 => 9,  49 => 4,  40 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends \"base.html.twig\" %}

{% block main %}
    <h1>Edit Film</h1>
    <section>
        <form method=\"POST\">
            <div>
                <label for=\"name\">Name</label>
                <input type=\"text\" id=\"name\" value=\"{{ film.name }}\" name=\"film[name]\" />
                <label for=\"genre\">Genre</label>
                <input type=\"text\" id=\"genre\" value=\"{{ film.genre }}\" name=\"film[genre]\" />
                <label for=\"director\">Director</label>
                <input type=\"text\" id=\"director\" value=\"{{ film.director }}\" name=\"film[director]\" />
                <label for=\"year\">Year</label>
                <input type=\"text\" id=\"year\" value=\"{{ film.year }}\" name=\"film[year]\" />

                {{ form_row(form._token) }}

                <button type=\"submit\" class=\"accept\">Edit</button>
                <button type=\"button\" onclick=\"location.href='/'\" class=\"cancel\">Cancel</button>
            </div>
        </form>
    </section>
{% endblock %}", ":film:edit.html.twig", "D:\\PHP Skeleton\\app/Resources\\views/film/edit.html.twig");
    }
}
